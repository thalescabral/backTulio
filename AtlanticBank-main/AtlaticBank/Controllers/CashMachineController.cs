using AtlanticBankData.Context;
using AtlanticBankDomain.Enum;
using AtlanticBankDomain.Interfaces;
using AtlanticBankDomain.Models;
using AtlanticBankDomain.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlaticBank.Controllers
{
    
    [ApiController]
    [Route("AtlanticBank/[controller]")]
    public class CashMachineController : ControllerBase
    {
        private readonly ApiDbContext _context;
        private readonly ICashMachineRepository _cashMachineRepository;
        private readonly ICashMachineService _cashMachineService;
        private readonly IMapper _mapper;

        public CashMachineController(ICashMachineRepository cashMachineRepository,
                                     ICashMachineService cashMachineService,
                                     IMapper mapper,
                                     ApiDbContext context)
        {
            _cashMachineRepository = cashMachineRepository;
            _cashMachineService = cashMachineService;
            _mapper = mapper;
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<CashMachineViewModel>> GetAllCashMachines()
        {
            try
            {
                var cashMachineResultAll = _mapper.Map<IEnumerable<CashMachineViewModel>>(await _cashMachineRepository.GetAllCashMachines());
                return cashMachineResultAll;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<CashMachineViewModel>> GetCashMachinesById(Guid id)
        {
            var cashMachineResultById = _mapper.Map<CashMachineViewModel>(await _cashMachineRepository.GetCashMachinesById(id));

            if (cashMachineResultById == null)
            {
                return NotFound();
            }

            return Ok(cashMachineResultById);
        }

        [AllowAnonymous]
        [HttpPatch("{idCashMachine:guid}")]
        public async Task<ActionResult<CashMachineViewModel>> UpdateCashMachineStatus(Guid idCashMachine, CashMachineViewModel cashMachineViewModel)
        {
            var getStatus = await getCashMachine(idCashMachine);

            if (getStatus != null) 
            { 
                if (idCashMachine != getStatus.Id)
                {
                    return BadRequest("Os caixas informados não são iguais!");
                }
            }

            if (getStatus != null)
            {
                getStatus.Status = cashMachineViewModel.Status;
            }

            try
            {
                await _cashMachineRepository.Update(_mapper.Map<CashMachine>(getStatus));
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        [AllowAnonymous]
        private async Task<CashMachineViewModel> getCashMachine(Guid id)
        {
            return _mapper.Map<CashMachineViewModel>(await _cashMachineRepository.GetCashMachinesById(id));
        }
    }
}

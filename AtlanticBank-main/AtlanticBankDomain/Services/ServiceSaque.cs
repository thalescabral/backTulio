using AtlanticBankDomain.Enum;
using AtlanticBankDomain.Interfaces;
using AtlanticBankDomain.Models;
using AtlanticBankDomain.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AtlanticBankDomain.Services
{
    public class ServiceSaque //: IServiceSaque
    {
        private readonly IServiceSaque _serviceSaque;
        private readonly IMapper _mapper;
        private readonly ICashMachineRepository _cashMachineRepository;
        private readonly ISaqueRepository _saqueRepository;

        public ServiceSaque(IServiceSaque serviceSaque,
                            IMapper mapper,
                            ICashMachineRepository cashMachineRepository,
                            ISaqueRepository saqueRepository)
        {
            _serviceSaque = serviceSaque;
            _mapper = mapper;
            _cashMachineRepository = cashMachineRepository;
            _saqueRepository = saqueRepository;
        }

        /*public async Task<CashMachineViewModel> SaqueService(SaqueViewModel saqueViewModel, Guid id)
        {
            bool cashMachineIsValid, moneyIsValid;

            var saqueModel = _mapper.Map<SaqueViewModel, Saque>(saqueViewModel);

            var cashMachineData = await _cashMachineRepository.GetCashMachinesById(id);
            //await _caixasRepository.CaixasAsync(saqueDomain.IdCaixa, _correlationId);

            cashMachineIsValid = ValidateCashMachine(cashMachineData, saqueModel);

            moneyIsValid = ValidateMoney(saqueModel.Value, ref cashMachineData);

            if (cashMachineIsValid && moneyIsValid)
            {
                var caixaComSaque = await _saquesRepository.SaqueAsync(saqueDomain, caixa, _correlationId);

                await _produtoService.Atualizar(_mapper.Map<Produto>(produtoAtualizacao));

                result = _mapper.Map<Caixa, CaixaViewModel>(caixaComSaque);
            }


            return result;
        }*/

        private bool ValidateCashMachine(CashMachine cashMachineData, Saque saqueModel)
        {
            bool returnStatus;

            if (cashMachineData.Status == 1 && cashMachineData.Balance > saqueModel.Value)
            {
                returnStatus = true;
            }
            else 
            {
                returnStatus = false;
            }

            return returnStatus;
        }

        private bool ValidateMoney(decimal value, ref CashMachine cashMachine)
        {
            bool result;

            if (value % 50 == 0)
            {
                cashMachine.Balance -= (long)value;
                cashMachine.Fifty -= (int)(value / 50);
                result = true;
            }
            else if (value % 50 > 0 && (value % 50) % 20 == 0)
            {
                cashMachine.Balance -= (long)value;
                cashMachine.Fifty -= (int)(value / 50);
                cashMachine.Twenty -= (int)((value % 50) / 20);
                result = true;
            }
            else if ((value % 50) % 20 > 0 && ((value % 50) % 20) % 10 == 0)
            {
                cashMachine.Balance -= (long)value;
                cashMachine.Fifty = cashMachine.Fifty - (int)(value / 50);
                cashMachine.Twenty = cashMachine.Twenty - (int)((value % 50) / 20);
                cashMachine.Ten = cashMachine.Ten - (int)(((value % 50) % 20) / 10);
                result = true;
            }
            else if (((value % 50) % 20) % 10 > 0 && (((value % 50) % 20) % 10) % 5 == 0)
            {
                cashMachine.Balance -= (long)value;
                cashMachine.Fifty = cashMachine.Fifty - (int)(value / 50);
                cashMachine.Twenty = cashMachine.Twenty - (int)((value % 50) / 20);
                cashMachine.Ten = cashMachine.Ten - (int)(((value % 50) % 20) / 10);
                cashMachine.Five = cashMachine.Five - (int)((((value % 50) % 20) % 10) / 5);
                result = true;
            }
            else if ((((value % 50) % 20) % 10) % 5 > 0 && ((((value % 50) % 20) % 10) % 5) % 2 == 0)
            {
                cashMachine.Balance -= (long)value;
                cashMachine.Fifty -= (int)(value / 50);
                cashMachine.Twenty -= (int)((value % 50) / 20);
                cashMachine.Ten -= (int)(((value % 50) % 20) / 10);
                cashMachine.Five -= (int)((((value % 50) % 20) % 10) / 5);
                cashMachine.Two -= (int)(((((value % 50) % 20) % 10) % 5) / 2);
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}

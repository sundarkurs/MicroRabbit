﻿
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }

        //public void Transfer(AccountTransfer accountTransfer)
        //{
        //    var createTransferCommand = new CreateTransferCommand(
        //            accountTransfer.FromAccount,
        //            accountTransfer.ToAccount,
        //            accountTransfer.TransferAmount
        //        );

        //    _bus.SendCommand(createTransferCommand);
        //}
    }
}

using PlatformService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDataServices.Http
{
    public interface ICommandClient
    {
        Task SendPlatformToCommand(PlatformReadDto platform);
    }
}

using System;
using JLaraSystemLeng.Progress.Dtos;
using Volo.Abp.Application.Services;

namespace JLaraSystemLeng.Progress;


public interface IProgresAppService :
    ICrudAppService< 
        ProgresDto, 
        Guid, 
        ProgresGetListInput,
        CreateUpdateProgresDto,
        CreateUpdateProgresDto>
{

}
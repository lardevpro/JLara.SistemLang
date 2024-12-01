using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace JLaraSystemLeng.Sugesstions.Dtos;

[Serializable]
public class SugesstionGetListInput : PagedAndSortedResultRequestDto
{
    public Guid? UserId { get; set; }

    public string? SugesstionText { get; set; }

    public DateTime? SugesstionCreationDate { get; set; }
}
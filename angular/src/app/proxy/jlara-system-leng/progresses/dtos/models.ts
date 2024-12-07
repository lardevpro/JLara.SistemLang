import type { FullAuditedEntityDto, PagedAndSortedResultRequestDto } from '@abp/ng.core';

export interface CreateUpdateProgressDto {
  userId?: string;
  practiceDate?: string;
  pronunciationAccuracy?: number;
  recommendation?: string;
  difficultyLevel?: string;
}

export interface ProgressDto extends FullAuditedEntityDto<string> {
  userId?: string;
  practiceDate?: string;
  pronunciationAccuracy?: number;
  recommendation?: string;
  difficultyLevel?: string;
}

export interface ProgressGetListInput extends PagedAndSortedResultRequestDto {
  userId?: string;
  practiceDate?: string;
  pronunciationAccuracy?: number;
  recommendation?: string;
  difficultyLevel?: string;
}

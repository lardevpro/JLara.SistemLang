import type { FullAuditedEntityDto, PagedAndSortedResultRequestDto } from '@abp/ng.core';

export interface CreateUpdateProgresDto {
  userId?: string;
  practiceDate?: string;
  pronunciationAccuracy?: number;
  recommendation?: string;
  difficultyLevel?: string;
}

export interface ProgresDto extends FullAuditedEntityDto<string> {
  userId?: string;
  practiceDate?: string;
  pronunciationAccuracy?: number;
  recommendation?: string;
  difficultyLevel?: string;
}

export interface ProgresGetListInput extends PagedAndSortedResultRequestDto {
  userId?: string;
  practiceDate?: string;
  pronunciationAccuracy?: number;
  recommendation?: string;
  difficultyLevel?: string;
}

import type { FullAuditedEntityDto, PagedAndSortedResultRequestDto } from '@abp/ng.core';

export interface CreateUpdateExerciseDto {
  userId?: string;
  phrase?: number;
  difficultyLevel?: string;
  focusArea?: string;
}

export interface ExerciseDto extends FullAuditedEntityDto<string> {
  userId?: string;
  phrase?: number;
  difficultyLevel?: string;
  focusArea?: string;
}

export interface ExerciseGetListInput extends PagedAndSortedResultRequestDto {
  userId?: string;
  phrase?: number;
  difficultyLevel?: string;
  focusArea?: string;
}

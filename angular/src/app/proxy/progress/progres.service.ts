import type { CreateUpdateProgresDto, ProgresDto, ProgresGetListInput } from './dtos/models';
import { RestService, Rest } from '@abp/ng.core';
import type { PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ProgresService {
  apiName = 'Default';
  

  create = (input: CreateUpdateProgresDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, ProgresDto>({
      method: 'POST',
      url: '/api/app/progres',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/progres/${id}`,
    },
    { apiName: this.apiName,...config });
  

  get = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, ProgresDto>({
      method: 'GET',
      url: `/api/app/progres/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (input: ProgresGetListInput, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<ProgresDto>>({
      method: 'GET',
      url: '/api/app/progres',
      params: { userId: input.userId, practiceDate: input.practiceDate, pronunciationAccuracy: input.pronunciationAccuracy, recommendation: input.recommendation, difficultyLevel: input.difficultyLevel, sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName,...config });
  

  update = (id: string, input: CreateUpdateProgresDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, ProgresDto>({
      method: 'PUT',
      url: `/api/app/progres/${id}`,
      body: input,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}

import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44333/',
  redirectUri: baseUrl,
  clientId: 'JLaraSystemLeng_App',
  responseType: 'code',
  scope: 'offline_access JLaraSystemLeng',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'JLaraSystemLeng',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44333',
      rootNamespace: 'JLaraSystemLeng',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;

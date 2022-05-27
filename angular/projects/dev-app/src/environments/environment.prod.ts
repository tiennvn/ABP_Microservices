import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'MS',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44316',
    redirectUri: baseUrl,
    clientId: 'MS_App',
    responseType: 'code',
    scope: 'offline_access MS',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44316',
      rootNamespace: 'TMT.MS',
    },
    MS: {
      url: 'https://localhost:44341',
      rootNamespace: 'TMT.MS',
    },
  },
} as Environment;

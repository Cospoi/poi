export const environment = {
  production: false,
  application: {
    name: 'Gopick',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44374',
    clientId: 'Gopick_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'Gopick',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44374',
    },
  },
  localization: {
    defaultResourceName: 'Gopick',
  },
};

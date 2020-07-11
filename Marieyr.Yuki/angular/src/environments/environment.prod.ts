export const environment = {
  production: true,
  application: {
    name: 'Yuki',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44304',
    clientId: 'Yuki_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'Yuki',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44304',
    },
  },
  localization: {
    defaultResourceName: 'Yuki',
  },
};

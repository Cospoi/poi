const ENV = {
  dev: {
    apiUrl: 'http://localhost:44374',
    oAuthConfig: {
      issuer: 'http://localhost:44374',
      clientId: 'Gopick_App',
      clientSecret: '1q2w3e*',
      scope: 'Gopick',
    },
    localization: {
      defaultResourceName: 'Gopick',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44374',
    oAuthConfig: {
      issuer: 'http://localhost:44374',
      clientId: 'Gopick_App',
      clientSecret: '1q2w3e*',
      scope: 'Gopick',
    },
    localization: {
      defaultResourceName: 'Gopick',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};

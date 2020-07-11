const ENV = {
  dev: {
    apiUrl: 'http://localhost:44304',
    oAuthConfig: {
      issuer: 'http://localhost:44304',
      clientId: 'Yuki_App',
      clientSecret: '1q2w3e*',
      scope: 'Yuki',
    },
    localization: {
      defaultResourceName: 'Yuki',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44304',
    oAuthConfig: {
      issuer: 'http://localhost:44304',
      clientId: 'Yuki_App',
      clientSecret: '1q2w3e*',
      scope: 'Yuki',
    },
    localization: {
      defaultResourceName: 'Yuki',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};

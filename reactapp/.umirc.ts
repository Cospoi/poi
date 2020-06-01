import { defineConfig } from 'umi';

export default defineConfig({
  nodeModulesTransform: {
    type: 'none',
  },
  routes: [
    {
      path: '/',
      component: '@/layout/index',
      routes: [
        {
            path:'/',
            redirect:'/dashboard'
        },
        {
          path: '/dashboard',
          component: './Dashboard',
        },
        {
          path:'/content',
          component:'./Content'
        }
      ],
    },
  ],
  sass: {
    implementation: require('node-sass'),
  },
  cssModulesTypescriptLoader: {},
});

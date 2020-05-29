import { defineConfig } from 'umi';

export default defineConfig({
  nodeModulesTransform: {
    type: 'none',
  },
  routes: [
    { path: '/', component: '@/pages/index' },
  ], 
  sass: {
    implementation: require('node-sass'),
  },
  cssModulesTypescriptLoader: {}
});

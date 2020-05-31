import { defineConfig } from 'umi';

export default defineConfig({
  nodeModulesTransform: {
    type: 'none',
  },
  routes: [
    { path: '/', component: '@/layout/index' },
  ], 
  sass: {
    implementation: require('node-sass'),
  },
  cssModulesTypescriptLoader: {}
});
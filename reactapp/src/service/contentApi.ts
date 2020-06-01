import axios from 'axios';
import { Response } from '@/utils/type';

function checkStatus(response: { data: Response; status: number }): Response {
  if (response.status >= 200 && response.status < 300) {
    return { ...response.data };
  }
  return { datas: [], success: false, keywords: '' };
}

export const getList = (params: object) => {
  return axios.get('/api/contentList', { params }).then(checkStatus);
};

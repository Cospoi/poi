type contentList = {
  id: string;
  type: string;
  price: string;
  name: string;
};

let contentList = [
  {
    id: 1,
    name: '.net从入门到入土',
    type: 'react',
    price: '￥18',
  },
  {
    id: 2,
    name: '.net从入门到入土',
    type: 'react',
    price: '￥18',
  },
  {
    id: 3,
    name: '.net从入门到入土',
    type: 'react',
    price: '￥18',
  },
  {
    id: 4,
    name: '.net从入门到入土',
    type: 'react',
    price: '￥18',
  },
  {
    id: 5,
    name: '.net从入门到入土',
    type: 'react',
    price: '￥18',
  },
];

function getUrlParam(url: string, key: string) {
  var reg = new RegExp('(^|&)' + key + '=([^&]*)(&|$)');
  var result = url.split('?')[1].match(reg);
  var keywords = result ? decodeURIComponent(result[2]) : '';
  return keywords;
}

const getContentList = (req: { url: string;}, res: any ) => {
  console.log(req.url);
  let keywords = getUrlParam(req.url, 'keywords');
  let filterList =
    !keywords || keywords == ''
      ? contentList
      : contentList.filter((item: { name: string }) => {
          return item.name.indexOf(keywords) !== -1;
        });
   res.send({
       success:true,
       datas:filterList,
       keywords:keywords
   })
};

export default {
  '/api/contentList': getContentList,
};

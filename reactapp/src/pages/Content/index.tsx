import React, { useState, useEffect } from 'react';
import { Table, Input } from 'antd';
import { getList } from '@/service/contentApi';
import {Data,Response}from '@/utils/type'

const { Search } = Input;

const index = () => {
  let columns = [
    {
      title: '名称',
      dataIndex: 'name',
      key: 'name',
    },
    {
      title: '类型',
      dataIndex: 'type',
      key: 'type',
    },
    {
      title: '价格',
      dataIndex: 'price',
      key: 'price',
    },
    {
      title: '地址',
      dataIndex: 'adress',
      key: 'adress',
      render: (text: string) => (
        <>
          <a target="_blank" href={text}>
            查看
          </a>
        </>
      ),
    },
    {
      title: '编辑',
      dataIndex: 'name',
      key: 'name',
      render: (record: { id: string }) => (
        <>
          <a>编辑</a>
        </>
      ),
    },
  ];


  const [datas, setDatas] = useState<Data[]>([] as Data[]);
  const [keywords, setKeywords] = useState('');

  useEffect(() => {
    getDatas({ keywords });
  }, [keywords]);

  const getDatas = (params: object) => {
    getList({ params }).then((res: Response) => {
      setDatas(res.datas);
    });
  };

  const handleSearch = (keywords: string) => {
    setKeywords(keywords);
  };

  return (
    <div>
      <Search
        placeholder="请输入搜索名称"
        onSearch={handleSearch}
        style={{ width: 200 }}
      />
      <Table
        columns={columns}
        dataSource={datas}
        rowKey={(datas: { id: string }) => datas.id}
      ></Table>
    </div>
  );
};

export default index;

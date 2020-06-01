import React, { ReactChildren } from 'react';
import { Layout, Menu } from 'antd';
import { Link, useHistory } from 'umi';
import styles from './index.scss';

const { Header, Footer, Content, Sider } = Layout;

const index = (props: { children: React.ReactNode }) => {
  const { location } = useHistory();

  return (
    <Layout className={styles.layout}>
      <Sider breakpoint="lg" collapsedWidth="0">
        <div className="title">后台管理</div>
        <Menu
          theme="dark"
          mode="inline"
          selectedKeys={[location.pathname]}
        >
          <Menu.Item key="/dashboard">
            <Link to="/dashboard">仪表盘</Link>
          </Menu.Item>
          <Menu.Item key="/content">
            <Link to="/content">内容</Link>
          </Menu.Item>
        </Menu>
      </Sider>
      <Layout className="poi-layout">
        <Header
          className="poi-layout-background"
          style={{ padding: 0 }}
        ></Header>
        <Content
          className="poi-layout-background"
          style={{
            margin: '24px 16px',
            padding: '24px',
            minHeight: 'max-content',
          }}
        >
          {props.children}
        </Content>
        <Footer style={{ textAlign: 'center' }}>created by poi</Footer>
      </Layout>
    </Layout>
  );
};

export default index;

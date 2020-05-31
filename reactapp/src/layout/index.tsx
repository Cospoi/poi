import React, { ReactChildren } from 'react'
import { Layout, Menu } from 'antd'
import { Link, useHistory } from 'umi'
import styles from './index.scss'

const { Header, Footer, Content, Sider } = Layout


const index = (props: { children: React.ReactNode }) => {
    const { location } = useHistory();

    return (
        <Layout className={styles.layout}>
            <Sider>
                <div className='title'>
                    后台管理
                </div>
                <Menu theme="dark">
                    <Menu.Item>
                        仪表盘
                    </Menu.Item>
                </Menu>
            </Sider>
            <Layout>
                <Header></Header>
                <Content> 123</Content>
                <Footer></Footer>
            </Layout>
        </Layout>
    )
}

export default index

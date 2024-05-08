import React, { useState } from 'react';
import {
  SolutionOutlined,
  ReconciliationOutlined,
  BlockOutlined,
  MenuFoldOutlined,
  MenuUnfoldOutlined,
  UploadOutlined,
  UserOutlined,
  VideoCameraOutlined,
} from '@ant-design/icons';
import { Layout, Menu, theme, Button } from 'antd';
import { Outlet, Link } from "react-router-dom";
import type { MenuProps } from 'antd';
const { Header, Sider, Content } = Layout;



const Root: React.FC = () => {
  const [collapsed, setCollapsed] = useState(false);
  const {
    token: { colorBgContainer, borderRadiusLG },
  } = theme.useToken();



  type MenuItem = Required<MenuProps>['items'][number];

  function getItem(
    label: React.ReactNode,
    key: React.Key,
    icon?: React.ReactNode,
    children?: MenuItem[],
  ): MenuItem {
    return {
      key,
      icon,
      children,
      label,
    } as MenuItem;
  }


  const items: MenuItem[] = [
    getItem('Solicitar', 'L1', <SolutionOutlined />,
      [
        getItem(<Link to="/Alquiler">Alquiler</Link>, 'L1_18'),
        getItem(<Link to="/">Reserva</Link>, 'A2_1'),
      ]),
    getItem('Catalogo', 'C1', <BlockOutlined />,
      [
        getItem(<Link to="/Entidad">Entidad</Link>, 'C1_6'),
        getItem(<Link to="/Tarifa">Tarifa</Link>, 'C1_7'),
        getItem(<Link to="/Servicio">Servicio</Link>, 'C1_8'),
        getItem(<Link to="/Infraestrutura/Menu">Infraestrutura</Link>, 'C1_56'),
      ]),
  ];
  return (


    <Layout style={{ minHeight: '100vh', marginTop: '-8px', marginLeft: '-8px', marginBottom: '-8px', }}>
      <Sider
        trigger={null} collapsible collapsed={collapsed}

      >
        <div style={{ height: '60px',  background: '#001529' }}  >
          {/* <svg version="1.1" style={{ marginTop: '70px', marginLeft: '45px', alignContent: 'center' }} width="100px" height="100px" viewBox="-0.5 -0.5 172 172" ><defs /><g><ellipse cx="85" cy="85" rx="85" ry="85" fill="#001529" stroke="rgb(0, 0, 0)" pointer-events="all" /><path d="M 50 91 L 130 91 L 130 70 L 150 100 L 130 130 L 130 109 L 50 109 Z" fill="#15616d" stroke="#15616d" stroke-miterlimit="10" pointer-events="all" /><path d="M 20 61 L 100 61 L 100 40 L 120 70 L 100 100 L 100 79 L 20 79 Z" fill="#15616d" stroke="#15616d" stroke-miterlimit="10" transform="rotate(180,70,70)" pointer-events="all" /></g></svg> */}
        </div>
        <Menu
          theme="dark"
          mode="inline"
          defaultSelectedKeys={['1']}
          items={items}

        >

        </Menu>
      </Sider>
      <Layout>
        <Header style={{ padding: 0, background:'#D6D6D6' }}>
          <Button
            type="text"
            icon={collapsed ? <MenuUnfoldOutlined /> : <MenuFoldOutlined />}
            onClick={() => setCollapsed(!collapsed)}
            style={{
              fontSize: '16px',
              width: 64,
              height: 64,
            }}
          />
          <h3 style={{ color: 'black', float: 'right', marginTop: '-2px', marginRight: '10px' }}>David Timo</h3>


        </Header>
        <Content
          style={{
            margin: '24px 16px',
            padding: 10,
            minHeight: 280,
            background: colorBgContainer,
            borderRadius: borderRadiusLG,
          }}
        >
          <Outlet />
        </Content>
      </Layout>
    </Layout>
  );
};
export default Root;

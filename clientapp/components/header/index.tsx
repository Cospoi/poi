import Link from "next/link";
import css from "./index.module.scss";
import { Switch } from "../custom";
import { useEffect, useState } from "react";
import { useSelector, useDispatch } from "react-redux";
import { IMenuProps, IMenuData } from "../../entity";
import { changeThemeDefault, changeThemeDark } from "../../store/store";

const menuData = [
  {
    id: 1,
    title: "首页",
    targetUrl: "#",
    children: [
      {
        id: 11,
        title: "下拉1",
        targetUrl: "#",
        children: null,
      },
    ],
  },
  {
    id: 2,
    title: "关于",
    targetUrl: "#",
    children: [
      {
        id: 21,
        title: "下拉1",
        targetUrl: "#",
        children: null,
      },
      {
        id: 22,
        title: "下拉2",
        targetUrl: "#",
        children: null,
      },
    ],
  },
  {
    id: 3,
    title: "友链",
    targetUrl: "#",
    children: null,
  },
  {
    id: 4,
    title: "归档",
    targetUrl: "#",
    children: [
      {
        id: 41,
        title: "下拉1",
        targetUrl: "#",
        children: null,
      },
      {
        id: 42,
        title: "下拉2",
        targetUrl: "#",
        children: null,
      },
      {
        id: 43,
        title: "下拉3",
        targetUrl: "#",
        children: null,
      },
    ],
  },
];

const index = () => {
  const theme = useSelector((state) => state.theme);
  const dispatch = useDispatch();

  let changeThemeHandle = () => {
    switch (theme) {
      case 0:
        dispatch(changeThemeDark());
        return;
      case 1:
        dispatch(changeThemeDefault());
        return;
    }
  };

  return (
    <header className={css.poi_header}>
      <nav className={css.poi_nav}>
        <Menu data={menuData} />
        <div className={css.poi_navright}>
          <a href="#!">统计</a>
          <Switch
            checked={theme === 1 ? true : false}
            onClick={changeThemeHandle}
          />
        </div>
      </nav>
    </header>
  );
};

const Menu = (props: IMenuProps) => {
  return (
    <ul className={css.poi_navleft}>
      {props.data.map((item, index) => (
        <MenuItem key={index} {...item} />
      ))}
    </ul>
  );
};

const MenuItem = (props: IMenuData) => {
  const [menuOpen, setMenuOpen] = useState<boolean | null>(null);
  let mouseMoveHandle = () => {
    setMenuOpen(true);
  };
  let mouseLeaveHandle = (e: React.MouseEvent<HTMLLIElement, MouseEvent>) => {
    setMenuOpen(false);
  };
  return (
    <li onMouseMove={mouseMoveHandle} onMouseLeave={mouseLeaveHandle}>
      <Link href={props.targetUrl}>
        <a>
          <span>{props.title}</span>
          <i className={props.children ? css.angle_down : ""}></i>
        </a>
      </Link>
      {props.children ? (
        <ul className={menuOpen === null ? "" : menuOpen ? css.act : css.hid}>
          {props.children.map((item, index) => (
            <MenuItem key={index} {...item} children={null} />
          ))}
        </ul>
      ) : (
        ""
      )}
    </li>
  );
};

export default index;

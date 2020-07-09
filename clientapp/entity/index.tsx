//theme
export interface InitialState {
  theme: ITheme;
}
export interface ITheme {
  id: number;
  name: string;
}
//nav

export interface IMenuData {
  id: number;
  title: string;
  targetUrl: string;
  children: IMenuData[] | null;
}
export interface IMenuProps {
  data: IMenuData[];
}

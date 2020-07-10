//theme
export interface IInitialState {
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
//article
export interface IArticle {
  id: number;
  title: string; 
  summer: string;
  content?:string;
  viewCount: number;
  createDate: string;
  fontCount: number;
}

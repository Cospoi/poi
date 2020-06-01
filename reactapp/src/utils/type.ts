export interface Data {
  id: string;
  type: string;
  price: string;
  name: string;
}
export type Response = {
  datas: Data[];
  keywords: string;
  success: boolean;
};

import css from "./index.module.scss";
import { IArticle } from "../../entity";

export default (props: IArticle) => {
  return (
    <article className={css.poi_article}>
      <h2>{props.title}</h2>
      <aside>
        <span>日期：{props.createDate}</span>
        <span>字数：{props.fontCount}</span>
        <span>查看：{props.viewCount}</span>
      </aside>
      <summary>{props.summer}</summary>
    </article>
  );
};

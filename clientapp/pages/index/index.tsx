import Layout from "../../components/layout";
import css from "./index.module.scss";
import ArticleCard from "../../components/articleCard";
import { IArticle } from "../../entity";
import { useState } from "react";
import Wapper from "../../components/wapper";

const initializeData: IArticle[] = [
  {
    id: 1,
    title: "一天掉多少根头发",
    summer:
      "一般来说， 所谓一天掉多少根头发，关键是一天掉多少根头发需要如何写。 卢梭曾经说过，浪费时间是一桩大罪过。一般来说， 所谓一天掉多少根头发，关键是一天掉多少根头发需要如何写。 卢梭曾经说过，浪费时间是一桩大罪过。一般来说， 所谓一天掉多少根头发，关键是一天掉多少根头发需要如何写。 卢梭曾经说过，浪费时间是一桩大罪过。",
    viewCount: 100,
    createDate: "2020-10-10",
    fontCount: 5000,
  },
  {
    id: 1,
    title: "奥力给干了兄弟们",
    summer:
      "我们一般认为，抓住了问题的关键，其他一切则会迎刃而解。 奥力给干了兄弟们，到底应该如何实现。一般来说， 所谓一天掉多少根头发，关键是一天掉多少根头发需要如何写。 卢梭曾经说过，浪费时间是一桩大罪过。一般来说， 所谓一天掉多少根头发，关键是一天掉多少根头发需要如何写。 卢梭曾经说过，浪费时间是一桩大罪过。",
    viewCount: 100,
    createDate: "2020-10-10",
    fontCount: 5000,
  },
  {
    id: 1,
    title: "一天掉多少根头发",
    summer:
      "一般来说， 所谓一天掉多少根头发，关键是一天掉多少根头发需要如何写。 卢梭曾经说过，浪费时间是一桩大罪过。一般来说， 所谓一天掉多少根头发，关键是一天掉多少根头发需要如何写。 卢梭曾经说过，浪费时间是一桩大罪过。一般来说， 所谓一天掉多少根头发，关键是一天掉多少根头发需要如何写。 卢梭曾经说过，浪费时间是一桩大罪过。",
    viewCount: 100,
    createDate: "2020-10-10",
    fontCount: 5000,
  },
];

export default () => {
  const [articleListData, setArticleListData] = useState<IArticle[]>(
    initializeData
  );
  return (
    <Layout>
      <Wapper />
      <div className={css.container}>
        <div className={css.leftcontainer}>
          {articleListData.map((item) => (
            <ArticleCard {...item} />
          ))}
        </div>
        <div className={css.rightcontainer}></div>
      </div>
    </Layout>
  );
};

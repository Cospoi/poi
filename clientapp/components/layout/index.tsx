import Meta from "../meta";
import Footer from "../footer";
import Header from "../header";
import css from "./index.module.scss";

interface Props {
  preview?: boolean;
  children: React.ReactNode;
}

export default (props: Props) => {
  return (
    <>
      <Meta />
      <Header />
      <figure></figure>
      <main>{props.children}</main>
      <Footer />
    </>
  );
};

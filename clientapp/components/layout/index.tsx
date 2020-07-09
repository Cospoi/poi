import Meta from "../meta";
import Footer from "../footer";
import Header from "../header";

interface Props {
  preview?: boolean;
  children: React.ReactNode;
}

const index = (props: Props) => {
  return (
    <>
      <Meta />
      <Header />
      <main>{props.children}</main>
      <Footer />
    </>
  );
};

export default index;

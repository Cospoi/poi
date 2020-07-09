import css from "./index.module.scss";
import classnames from "classnames";

interface ISwitchProps {
  checked: boolean;
  onClick: () => void;
}
export const Switch = (props: ISwitchProps) => {
  return (
    <input
      type="checkbox"
      className={classnames(css.poi_switch, css.poi_switch_anim)}
      defaultChecked={props.checked}
      onClick={props.onClick}
    />
  );
};

import "../styles/app.scss";
import { Provider } from "react-redux";
import { useStore } from "../store/store";
import { persistStore } from "redux-persist";
import { PersistGate } from "redux-persist/integration/react";

function App({ Component, pageProps }) {
  const store = useStore(pageProps.initialReduxState);
  const persistor = persistStore(store);
  return (
    <Provider store={store}>
      <PersistGate loading={<Component {...pageProps} />} persistor={persistor}>
        <Component {...pageProps} />
      </PersistGate>
    </Provider>
  );
}

export default App;

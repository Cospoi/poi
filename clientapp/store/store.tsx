import { useMemo } from "react";
import { createStore, applyMiddleware } from "redux";
import { composeWithDevTools } from "redux-devtools-extension";
import { persistReducer } from "redux-persist";
import storage from "redux-persist/lib/storage";
import { InitialState } from "../entity";

let store;

const InitialState = {
  theme: {
    id: 0,
    name: "默认主题",
  },
};

const THEME_DEFAULT = "THEME_DEFAULT";
type THEME_DEFAULT = typeof THEME_DEFAULT;

const THEME_DARK = "THEME_DARK";
type THEME_DARK = typeof THEME_DARK;

//ACTIONS
interface THEME_DEFAULTAction {
  type: THEME_DEFAULT;
}
interface THEME_DARKAction {
  type: THEME_DARK;
}

type actionTypes = THEME_DEFAULTAction | THEME_DARKAction;

// REDUCERS
export const reducer = (
  state: InitialState = InitialState,
  action: actionTypes
): InitialState => {
  switch (action.type) {
    case THEME_DEFAULT:
      return {
        ...state,
        theme: {
          id: 0,
          name: "默认主题",
        },
      };
    case THEME_DARK:
      return {
        ...state,
        theme: {
          id: 1,
          name: "暗黑主题",
        },
      };

    default:
      return state;
  }
};

const persistConfig = {
  key: "poi",
  storage,
  whitelist: ["theme"], // place to select which state you want to persist
};

const persistedReducer = persistReducer(persistConfig, reducer);

function makeStore(initialState = InitialState) {
  return createStore(
    persistedReducer,
    initialState,
    composeWithDevTools(applyMiddleware())
  );
}

export const initializeStore = (preloadedState) => {
  let _store = store ?? makeStore(preloadedState);

  // After navigating to a page with an initial Redux state, merge that state
  // with the current state in the store, and create a new store
  if (preloadedState && store) {
    _store = makeStore({
      ...store.getState(),
      ...preloadedState,
    });
    // Reset the current store
    store = undefined;
  }

  // For SSG and SSR always create a new store
  if (typeof window === "undefined") return _store;
  // Create the store once in the client
  if (!store) store = _store;

  return _store;
};

export function useStore(initialState) {
  const store = useMemo(() => initializeStore(initialState), [initialState]);
  return store;
}

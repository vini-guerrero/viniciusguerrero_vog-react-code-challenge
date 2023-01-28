import React from "react";
import { createRoot } from "react-dom/client";
import { Provider } from "react-redux";
import { mainStore } from "./src/stores/mainStore";
import App from "./src/App";

const domNode = document.getElementById("root");
const root = createRoot(domNode);
root.render(
  <Provider store={mainStore}>
    <App />
  </Provider>
);

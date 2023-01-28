import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Departments from "./pages/departments";
import Employees from "./pages/employees";
import Layout from "./pages/layout";
import "./app.css";

const App = () => {
  return (
    <Router>
      <Routes>
        <Route path="/" exact element={<Layout />}>
          <Route path="/departments" element={<Departments />} />
          <Route path="/employees" element={<Employees />} />
        </Route>
      </Routes>
    </Router>
  );
};

export default App;

import { configureStore } from "@reduxjs/toolkit";
import departmentsReducer from "../reducers/departmentsReducer";
import employeesReducer from "../reducers/employeesReducer";

export const mainStore = configureStore({
  reducer: {
    departments: departmentsReducer,
    employees: employeesReducer,
  },
});

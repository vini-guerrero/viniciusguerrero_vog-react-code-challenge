import axios from "axios";

const baseApi = axios.create({
  baseURL: "http://localhost:30001/",
  timeout: 50000,
  headers: {
    "Content-Type": "application/json;",
  },
});

export function fetchDepartments(id = "") {
  return baseApi({
    url: `departments/${id}`,
    method: "get",
  });
}

export function fetchEmployees(id = "") {
  return baseApi({
    url: `employees/${id}`,
    method: "get",
  });
}

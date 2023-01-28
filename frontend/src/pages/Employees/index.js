import React, { useEffect, useState } from "react";
import EmployeeItem from "../../components/EmployeeItem";
import AddEmployee from "../../components/AddEmployee";
import EmployeeTableHeader from "../../components/EmployeeTableHeader";
import "./index.css";

import { getEmployees } from "../../reducers/employeesReducer";
import { getDepartments } from "../../reducers/departmentsReducer";
import { useDispatch, useSelector } from "react-redux";

const Employees = () => {
  const dispatch = useDispatch();
  const [departmentSearch, setDepartmentSearch] = useState("");
  const [newEmployees, setNewEmployees] = useState([]);
  const loading = useSelector((state) => state.loading);
  const departments = useSelector((state) => state.departments.data);
  const employees = useSelector((state) => {
    const filtered = departments.filter((item) =>
      item?.departmentName
        .toLowerCase()
        .trim()
        .includes(departmentSearch.toLowerCase().trim())
    );
    return (
      departmentSearch && filtered[0]
        ? filtered[0]?.employees
        : state.employees.data
    ).concat(newEmployees);
  });

  useEffect(() => {
    dispatch(getDepartments());
    dispatch(getEmployees());
  }, [newEmployees]);

  const renderEmployee = () => {
    return loading && !employees.length ? (
      <></>
    ) : (
      employees.map((data, i) => {
        return (
          <EmployeeItem
            key={i}
            firstName={data?.firstName}
            lastName={data?.lastName}
            jobTitle={data?.jobTitle}
            address={data?.address}
          />
        );
      })
    );
  };

  const addNewEmploy = (newEmployees) => {
    newEmployees.map((data, i) => {
      return (
        <EmployeeItem
          key={i}
          firstName={data?.firstName}
          lastName={data?.lastName}
          jobTitle={data?.jobTitle}
          address={data?.address}
        />
      );
    });
  };

  const getDepartmentFilter = (event) =>
    setDepartmentSearch(event?.target.value);

  function addEmployeeHandler(data) {
    setNewEmployees(newEmployees.concat(data));
  }

  return (
    <div className="antialiased font-sans bg-gray-200">
      <div className="container mx-auto px-4 sm:px-8">
        <div className="py-8">
          <div>
            <h2 className="text-2xl font-semibold leading-tight">Employees</h2>
          </div>
          <div className="my-2 flex sm:flex-row flex-col">
            <div className="block relative">
              <span className="h-full absolute inset-y-0 left-0 flex items-center pl-2">
                <svg
                  viewBox="0 0 24 24"
                  className="h-4 w-4 fill-current text-gray-500"
                >
                  <path d="M10 4a6 6 0 100 12 6 6 0 000-12zm-8 6a8 8 0 1114.32 4.906l5.387 5.387a1 1 0 01-1.414 1.414l-5.387-5.387A8 8 0 012 10z"></path>
                </svg>
              </span>
              <input
                onChange={getDepartmentFilter}
                placeholder="Department"
                className="appearance-none rounded-r rounded-l sm:rounded-l-none border border-gray-400 border-b block pl-8 pr-6 py-2 w-full bg-white text-sm placeholder-gray-400 text-gray-700 focus:bg-white focus:placeholder-gray-600 focus:text-gray-700 focus:outline-none"
              />
            </div>
          </div>
          <AddEmployee addEmployeeHandler={addEmployeeHandler} />
          <div className="-mx-4 sm:-mx-8 px-4 sm:px-8 py-4 overflow-x-auto">
            <div className="inline-block min-w-full shadow rounded-lg overflow-hidden">
              <table className="min-w-full leading-normal">
                <EmployeeTableHeader />
                <tbody>{renderEmployee()}</tbody>
              </table>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Employees;

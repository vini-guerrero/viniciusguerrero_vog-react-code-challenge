import React, { useEffect, useState } from "react";
import DepartmentItem from "../../components/DepartmentItem";
import "./index.css";

import { getDepartments } from "../../reducers/departmentsReducer";
import { useDispatch, useSelector } from "react-redux";

const Departments = () => {
  const dispatch = useDispatch();
  const [departmentSearch, setDepartmentSearch] = useState("");
  const loading = useSelector((state) => state.loading);
  const departments = useSelector((state) => {
    const filtered = state.departments.data.filter((item) =>
      item?.departmentName
        .toLowerCase()
        .includes(departmentSearch.toLowerCase())
    );
    return departmentSearch && filtered ? filtered : state.departments.data;
  });

  useEffect(() => {
    dispatch(getDepartments());
  }, []);

  const getDepartmentFilter = (event) =>
    setDepartmentSearch(event?.target.value);

  const renderDepartments = () => {
    return loading && !departments.length ? (
      <></>
    ) : (
      departments.map((data, i) => {
        return (
          <DepartmentItem
            key={data?.departmentId}
            departmentId={data?.departmentId}
            departmentName={data?.departmentName}
          />
        );
      })
    );
  };

  return (
    <div className="antialiased font-sans bg-gray-200">
      <div className="container mx-auto px-4 sm:px-8">
        <div className="py-8">
          <div>
            <h2 className="text-2xl font-semibold leading-tight">
              Departments
            </h2>
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
          <div className="-mx-4 sm:-mx-8 px-4 sm:px-8 py-4 overflow-x-auto">
            <div className="inline-block min-w-full shadow rounded-lg overflow-hidden">
              <table className="min-w-full leading-normal">
                <thead>
                  <tr>
                    <th className="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                      Department Id
                    </th>
                    <th className="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                      Department Name
                    </th>
                  </tr>
                </thead>
                <tbody>{renderDepartments()}</tbody>
              </table>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Departments;

import React, { useState } from "react";
import EmployeeField from "../EmployeeField";

const AddEmployee = ({ addEmployeeHandler }) => {
  const [employee, setEmployee] = useState({
    firstName: "",
    lastName: "",
    jobTitle: "",
    address: "",
  });

  function handleChange(evt) {
    const value = evt.target.value;
    setEmployee({
      ...employee,
      [evt.target.name]: value,
    });
  }
  const handleClick = () => {
    addEmployeeHandler(employee);
  };

  return (
    <>
      <div className="my-2 flex sm:flex-row flex-col">
        <EmployeeField
          placeholder={"First Name"}
          name="firstName"
          value={employee.firstName || ""}
          onChange={handleChange}
        />
        <EmployeeField
          placeholder={"Last Name"}
          name="lastName"
          value={employee.lastName || ""}
          onChange={handleChange}
        />
        <EmployeeField
          placeholder={"Job Title"}
          name="jobTitle"
          value={employee.jobTitle || ""}
          onChange={handleChange}
        />
        <EmployeeField
          placeholder={"Address"}
          name="address"
          value={employee.address || ""}
          onChange={handleChange}
        />

        <div className="block relative">
          <span className="h-full absolute inset-y-0 left-0 flex items-center pl-2">
            <button
              onClick={handleClick}
              className="text-sm bg-gray-300 hover:bg-gray-400 text-gray-800 font-semibold py-2 px-4 rounded-lg"
            >
              Add
            </button>
          </span>
        </div>
      </div>
    </>
  );
};

export default AddEmployee;

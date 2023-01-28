import React from "react";

const EmployeeItem = ({ firstName, lastName, jobTitle, address }) => {
  return (
    <>
      <tr>
        <td className="px-2 py-2 border-b border-gray-200 bg-white text-sm">
          <div className="flex items-center">
            <div className="ml-2">
              <p className="text-gray-900 whitespace-no-wrap">{firstName}</p>
            </div>
          </div>
        </td>
        <td className="px-2 py-2 border-b border-gray-200 bg-white text-sm">
          <p className="text-gray-900 whitespace-no-wrap">{lastName}</p>
        </td>
        <td className="px-2 py-2 border-b border-gray-200 bg-white text-sm">
          <p className="text-gray-900 whitespace-no-wrap">{jobTitle}</p>
        </td>
        <td className="px-2 py-2 border-b border-gray-200 bg-white text-sm">
          <p className="text-gray-900 whitespace-no-wrap">{address}</p>
        </td>
      </tr>
    </>
  );
};

export default EmployeeItem;

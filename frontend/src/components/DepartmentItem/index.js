import React from "react";

const DepartmentItem = ({ departmentId, departmentName }) => {
  return (
    <>
      <tr>
        <td className="px-2 py-2 border-b border-gray-200 bg-white text-sm">
          <div className="flex items-center">
            <div className="ml-2">
              <p className="text-gray-900 whitespace-no-wrap">{departmentId}</p>
            </div>
          </div>
        </td>
        <td className="px-2 py-2 border-b border-gray-200 bg-white text-sm">
          <p className="text-gray-900 whitespace-no-wrap">{departmentName}</p>
        </td>
      </tr>
    </>
  );
};

export default DepartmentItem;

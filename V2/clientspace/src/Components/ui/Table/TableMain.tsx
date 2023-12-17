import React from "react";

interface Props extends React.TableHTMLAttributes<HTMLTableElement> { }

function TableMain(props: Props) {
    return (
        <table className="w-full text-sm text-left rtl:text-right text-black "
            {...props}>
            <thead className="w-full text-xs text-white uppercase bg-black ">
                <tr>
                    <th scope="col" className="p-4">
                        <div className="flex items-center">
                            <input
                                id="checkbox-all-search"
                                type="checkbox"
                                className="w-4 h-4 text-blue-600 bg-gray-100 border-gray-300 rounded focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-800 dark:focus:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600"
                            />
                            <label htmlFor="checkbox-all-search" className="sr-only">
                                checkbox
                            </label>
                        </div>
                    </th>
                    <th scope="col" className="px-6 py-6">
                        Nº
                    </th>
                    <th scope="col" className="px-6 py-6">
                        Tipo de Documento
                    </th>
                    <th scope="col" className="px-6 py-6">
                        Nº Documento
                    </th>
                    <th scope="col" className="px-6 py-6">
                        Nombre Completo
                    </th>
                    <th scope="col" className="px-6 py-6">
                        Usuario
                    </th>
                    <th scope="col" className="px-6 py-6">
                        Fecha de Registro
                    </th>
                    <th scope="col" className="px-6 py-6">
                        Accion
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr className="text-xs text-black uppercase ">
                    <td className="w-4 p-4">
                        <div className="flex items-center">
                            <input
                                id="checkbox-table-search-1"
                                type="checkbox"
                                className="w-4 h-4 text-blue-600 bg-gray-100 border-gray-300 rounded focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-800 dark:focus:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600"
                            />
                            <label htmlFor="checkbox-table-search-1" className="sr-only">
                                checkbox
                            </label>
                        </div>
                    </td>
                    <td className="px-6 py-6">1</td>
                    <td className="px-6 py-6">Silver</td>
                    <td className="px-6 py-6">Laptop</td>
                    <td className="px-6 py-6">$2999</td>
                    <td className="px-6 py-6">Laptop</td>
                    <td className="px-6 py-6">$2999</td>
                    <td>

                        {/* <button
                            type="button"
                            className="text-yellow-400 hover:text-white border border-yellow-400 hover:bg-yellow-500 focus:ring-4 focus:outline-none focus:ring-yellow-300 font-medium rounded-lg text-sm px-5 py-2.5 text-center me-2 mb-2 dark:border-yellow-300 dark:text-yellow-300 dark:hover:text-white dark:hover:bg-yellow-400 dark:focus:backdrop:to-black">
                            <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" className="w-3 h-3">
                                <path stroke-linecap="round" stroke-linejoin="round" d="M16.862 4.487l1.687-1.688a1.875 1.875 0 112.652 2.652L6.832 19.82a4.5 4.5 0 01-1.897 1.13l-2.685.8.8-2.685a4.5 4.5 0 011.13-1.897L16.863 4.487zm0 0L19.5 7.125" />
                            </svg>
                        </button> */}

                        <button
                            type="button"
                            className="flex flex-shrink-0 justify-center items-center gap-2 h-[2.375rem] w-[2.375rem] text-sm font-semibold rounded-lg border border-transparent bg-blue-600 text-white hover:bg-blue-700 disabled:opacity-50 disabled:pointer-events-none dark:focus:outline-none dark:focus:ring-1 dark:focus:ring-gray-600"
                        >
                            <svg
                                className="flex-shrink-0 w-3 h-3"
                                xmlns="http://www.w3.org/2000/svg"
                                width={24}
                                height={24}
                                viewBox="0 0 24 24"
                                fill="none"
                                stroke="currentColor"
                                strokeWidth={2}
                                strokeLinecap="round"
                                strokeLinejoin="round"
                            >
                                <path d="m3 9 9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z" />
                                <polyline points="9 22 9 12 15 12 15 22" />
                            </svg>
                        </button>
                    </td>

                </tr>
            </tbody>
            <tbody>
                <tr className="text-xs text-black uppercase ">
                    <td className="w-4 p-4">
                        <div className="flex items-center">
                            <input
                                id="checkbox-table-search-1"
                                type="checkbox"
                                className="w-4 h-4 text-blue-600 bg-gray-100 border-gray-300 rounded focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-800 dark:focus:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600"
                            />
                            <label htmlFor="checkbox-table-search-1" className="sr-only">
                                checkbox
                            </label>
                        </div>
                    </td>
                    <td className="px-6 py-6">2</td>
                    <td className="px-6 py-6">Silver</td>
                    <td className="px-6 py-6">Laptop</td>
                    <td className="px-6 py-6">$2999</td>
                    <td className="px-6 py-6">Laptop</td>
                    <td className="px-6 py-6">$2999</td>

                </tr>
            </tbody>
            <tbody>
                <tr className="text-xs text-black uppercase ">
                    <td className="w-4 p-4">
                        <div className="flex items-center">
                            <input
                                id="checkbox-table-search-1"
                                type="checkbox"
                                className="w-4 h-4 text-blue-600 bg-gray-100 border-gray-300 rounded focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-800 dark:focus:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600"
                            />
                            <label htmlFor="checkbox-table-search-1" className="sr-only">
                                checkbox
                            </label>
                        </div>
                    </td>

                    <td className="px-6 py-6">3</td>
                    <td className="px-6 py-6">Silver</td>
                    <td className="px-6 py-6">Laptop</td>
                    <td className="px-6 py-6">$2999</td>
                    <td className="px-6 py-6">Laptop</td>
                    <td className="px-6 py-6">$2999</td>
                </tr>
            </tbody>
        </table>
    )
}



export default TableMain;
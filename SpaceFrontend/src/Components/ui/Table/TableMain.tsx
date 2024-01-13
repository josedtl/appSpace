import React from "react";
import TButtonEditar from '../../../Components/ui/Button/TButtonEditar'
import TButtonEliminar from '../../../Components/ui/Button/TButtonEliminar'

interface Props extends React.TableHTMLAttributes<HTMLTableElement> { }

function TableMain(props: Props) {
    return (
        <table className="w-full text-sm text-left rtl:text-right text-black "
            {...props}>
            <thead className="w-full text-black uppercase bg-gray-100 px-1 py-1 ">
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
                    <th scope="col" className="px-6 py-4">
                        Nº
                    </th>
                    <th scope="col" className="px-6 py-4">
                        Tipo de Documento
                    </th>
                    <th scope="col" className="px-6 py-4">
                        Nº Documento
                    </th>
                    <th scope="col" className="px-6 py-4">
                        Nombre Completo
                    </th>
                    <th scope="col" className="px-6 py-4">
                        Usuario
                    </th>
                    <th scope="col" className="px-6 py-4">
                        Fecha de Registro
                    </th>
                    <th scope="col" className="px-6 py-4">
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
                        <div>
                            <TButtonEditar>
                            </TButtonEditar>
                        <TButtonEliminar/>
                        </div>
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
                    <td>
                        <div>
                            <TButtonEditar>
                            </TButtonEditar>
                        </div>
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

                    <td className="px-6 py-6">3</td>
                    <td className="px-6 py-6">Silver</td>
                    <td className="px-6 py-6">Laptop</td>
                    <td className="px-6 py-6">$2999</td>
                    <td className="px-6 py-6">Laptop</td>
                    <td className="px-6 py-6">$2999</td>
                    <td>
                        <div>
                            <TButtonEditar>
                            </TButtonEditar>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
    )
}



export default TableMain;
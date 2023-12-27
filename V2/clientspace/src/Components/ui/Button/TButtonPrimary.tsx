import React from "react";

interface Props extends React.ButtonHTMLAttributes<HTMLButtonElement> { }

function TButtonPrimary({ children, ...props }: Props) {
    return (

        <button
            className="middle none center mr-4 
            flex items-center justify-center rounded-lg bg-gradient-to-tr 
            bg-DRgreen hover:bg-DRgreenOscuro
            p-3 font-sans text-xs font-bold uppercase 
            text-white shadow-md  transition-all hover:shadow-lg             
            disabled:shadow-none"
            data-ripple-light="true"
            {...props}
        >{children}
        </button>
    )
}

export default TButtonPrimary;

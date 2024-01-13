import React from "react";

interface Props extends React.ButtonHTMLAttributes<HTMLButtonElement> { }

function TButtonPrimary({ children, ...props }: Props) {
    return (
        // <button
        //     className="middle none center mr-4 
        //     flex items-center justify-center rounded-lg bg-gradient-to-tr 
        //     bg-DRgreen hover:bg-DRgreenOscuro
        //     p-3 font-sans text-xs font-bold uppercase 
        //     text-white shadow-md  transition-all hover:shadow-lg             
        //     disabled:shadow-none"
        //     data-ripple-light="true"
        //     {...props}
        // >{children}
        // </button>


        <button
            className="middle none center mr-4 
            flex items-center justify-center rounded-lg bg-gradient-to-tr 
            bg-DRgreen hover:bg-DRgreenOscuro
            p-3 font-sans text-xs font-bold uppercase 
            text-white shadow-md  transition-all hover:shadow-lg             
            disabled:shadow-none"
            data-ripple-light="true"
            {...props}
        >
            <i className="fas fa-heart text-lg leading-none"></i>
            <svg className="h-5 w-5 text-white" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M12 4v16m8-8H4" />
            </svg>
        </button>


    )
}

export default TButtonPrimary;
import React from "react";

interface Props extends React.InputHTMLAttributes<HTMLInputElement> { }

 function Input(props: Props) {
    return (
        <input 
            className="w-full border-2 px-4 py-2 outline-none rounded-lg focus:border-orange-500"
            {...props}
        />
    )
}



export default Input;
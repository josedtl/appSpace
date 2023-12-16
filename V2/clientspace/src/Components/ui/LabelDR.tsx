import React from "react";

interface Props extends React.LabelHTMLAttributes<HTMLLabelElement> { }

function LabelDR({ children, ...props }: Props) {
    return (
        <label
            className="block text-gray-700 text-sm font-bold mb-2 px-1" 
            {...props}>
            {children}
        </label>
    )
}

export default LabelDR;


interface Props extends React.ButtonHTMLAttributes<HTMLButtonElement> { }

function TButtonPrimary({ children, ...props }: Props) {
    return (

        <button
            type="button"
            className="flex flex-shrink-0 
            justify-center items-center 
            gap-2 h-[2.375rem] w-[2.375rem]
            text-sm font-semibold rounded-lg 
            border-yellow-500 bg-white
            text-white hover:bg-red-50 disabled:opacity-50 
            disabled:pointer-events-none 
            dark:focus:outline-none 
            dark:focus:ring-1 dark:focus:ring-yellow-500"
            {...props}
        >
            <svg className="h-7 w-7 text-red-500" 
            viewBox="0 0 24 24" 
            fill="none"
                stroke="currentColor" 
                stroke-width="2" 
                stroke-linecap="round"
                stroke-linejoin="round"> 
                <polyline points="3 6 5 6 21 6" />
                <path d="M19 6v14a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2V6m3 0V4a2 2 0 0 1 2-2h4a2 2 0 0 1 2 2v2" />  <line x1="10" y1="11" x2="10" y2="17" />
                <line x1="14" y1="11" x2="14" y2="17" /></svg>

        </button>

    )
}

export default TButtonPrimary;
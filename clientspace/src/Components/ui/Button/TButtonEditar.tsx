interface Props extends React.ButtonHTMLAttributes<HTMLButtonElement> { }

function TButtonPrimary({ children, ...props }: Props) {
    return (


        <button
            type="button"
            className="flex flex-shrink-0 
                            justify-center items-center 
                            gap-2 h-[2.375rem] w-[2.375rem]
                            text-sm font-semibold rounded-lg 
                            border border-yellow-500 bg-white
                            text-white hover:bg-red-50 disabled:opacity-50 
                            disabled:pointer-events-none 
                            dark:focus:outline-none 
                            dark:focus:ring-1 dark:focus:ring-yellow-500"
                            {...props}
        >
            <svg className="h-6 w-6 text-yellow-500"
                width="24"
                height="24"
                viewBox="0 0 24 24"
                xmlns="http://www.w3.org/2000/svg"
                fill="none"
                stroke="currentColor"
                stroke-width="2"
                stroke-linecap="round"
                stroke-linejoin="round">
                <path d="M12 20h9" />
                <path d="M16.5 3.5a2.121 2.121 0 0 1 3 3L7 19l-4 1 1-4L16.5 3.5z" /></svg>

        </button>
    )
}

export default TButtonPrimary;
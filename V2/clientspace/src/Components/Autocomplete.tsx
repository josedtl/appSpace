import React, { useEffect, useRef, useState, KeyboardEvent } from "react";

interface Option {
    value: string;
    description: string;
}

interface AutocompleteProps {
    options: Option[];
    value: string;
    onChange: (value: string) => void;
}

const Autocomplete: React.FC<AutocompleteProps> = ({ options, value, onChange }) => {
    const [showOptions, setShowOptions] = useState<boolean>(false);
    const [cursor, setCursor] = useState<number>(-1);
    const ref = useRef<HTMLDivElement>(null);

    const select = (selectedValue: string) => {
        onChange(selectedValue);
        setShowOptions(false);
    };

    const handleChange = (text: string) => {
        onChange(text);
        setCursor(-1);
        if (!showOptions) {
            setShowOptions(true);
        }
    };

    const filteredOptions = options.filter((option) => option.description.includes(value));

    const moveCursorDown = () => {
        if (cursor < filteredOptions.length - 1) {
            setCursor((c) => c + 1);
        }
    };

    const moveCursorUp = () => {
        if (cursor > 0) {
            setCursor((c) => c - 1);
        }
    };

    const handleNav = (e: KeyboardEvent<HTMLInputElement>) => {
        switch (e.key) {
            case "ArrowUp":
                moveCursorUp();
                break;
            case "ArrowDown":
                moveCursorDown();
                break;
            case "Enter":
                if (cursor >= 0 && cursor < filteredOptions.length) {
                    select(filteredOptions[cursor].value);
                }
                break;
        }
    };

    useEffect(() => {
        const listener = (e: MouseEvent | FocusEvent) => {
            if (ref.current && !ref.current.contains(e.target as Node)) {
                setShowOptions(false);
                setCursor(-1);
            }
        };

        document.addEventListener('click', listener);
        document.addEventListener('focusin', listener);
        return () => {
            document.removeEventListener('click', listener);
            document.removeEventListener('focusin', listener);
        };
    }, []);

    return (
        <div className="relative w-64" ref={ref}>
            <input
                type="text"
                className="w-full border-2 px-4 py-2 outline-none rounded-lg"
                value={value}
                onChange={(e) => handleChange(e.target.value)}
                onFocus={() => setShowOptions(true)}
                onKeyDown={handleNav}
            />

            <ul className={`absolute w-full rounded-lg shadow-lg ${!showOptions && 'hidden'} select-none`}>
                {filteredOptions.length > 0 ? (
                    filteredOptions.map((option, i, arr) => {
                        let className = "px-4 hover:bg-gray-100 ";

                        if (i === 0) className += "pt-2 pb-1 rounded-t-lg";
                        else if (i === arr.length - 1) className += "pt-1 pb-2 rounded-b-lg";
                        else if (i === 0 && arr.length === 1) className += "py-2 rounded-lg";
                        else className += "py-1";

                        if (cursor === i) {
                            className += " bg-gray-100";
                        }

                        return (
                            <li
                                className={className}
                                key={option.value}
                                onClick={() => select(option.value)}
                            >
                                {option.description}
                            </li>
                        );
                    })
                ) : (
                    <li className="px-4 py-2 text-gray-500">No results</li>
                )}
            </ul>
        </div>
    );
};

export default Autocomplete;






interface Props {
    value: string;
    name: string;
    onChange: (e: React.ChangeEvent<HTMLInputElement>) => void;
    header: string;
}

const DR_Text: React.FC<Props> = (props) => {


    return (

   
            <div className="w-full m-10">
                <label className="block mb-1">{props.header}</label>
                <input
                    type="text"
                    className="w-full border-2 px-4 py-2 outline-none rounded-lg focus:border-blue-500"
                    value={props.value}
                    name={props.name}
                    onChange={props.onChange}
                />
            </div>
       
        
    )

}

export default DR_Text;
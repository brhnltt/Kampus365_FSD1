import { createContext, useState } from "react";

export const TodoContext = createContext();

export const TodoProvider = ({ children }) => {
    const [todos, setTodos] = useState([{ val: "Task 1", comp: false }, { val: "Task 2", comp: true }, { val: "Task 3", comp: false }]);

    function aaa() {

    }

    return (
        <TodoContext.Provider value={{ todos, aaa, setTodos }}>
            {children}
        </TodoContext.Provider>
    );
}
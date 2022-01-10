import { useEffect, useState } from "react";
import { getVisits, incrementVisits } from "./visits.service";

export const useVisits = (): [number, boolean, () => Promise<void>] => {
    const [visits, setVisits] = useState(0);
    const [isLoading, setIsLoading] = useState(false);

    useEffect(() => {
        (async () => {
            setIsLoading(true);
            const visitsCount = await getVisits();
            setVisits(visitsCount);
            setIsLoading(false);
        })();
    }, []);

    const increment = async () => {
        setIsLoading(true);
        await incrementVisits();
        const visitsCount = await getVisits();
        setVisits(visitsCount);
        setIsLoading(false);
    };

    return [visits, isLoading, increment]
};
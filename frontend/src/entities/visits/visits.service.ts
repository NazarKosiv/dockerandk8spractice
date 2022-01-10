const hostUrl = process.env.API as string;

export const getVisits = async () => {
    return await fetch(`${hostUrl}/api/visits`).then(r => r.json());
};

export const incrementVisits = async () => {
    return await fetch(`${hostUrl}/api/visits`, { method: 'PUT' }).then(r => r.json());
};

export const getVisits = async () => {
    return await fetch('/api/visits').then(r => r.json());
};

export const incrementVisits = async () => {
    return await fetch('/api/visits', { method: 'PUT' });
};

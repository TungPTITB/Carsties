/** @type {import('next').NextConfig} */
const nextConfig = {
    experimental: {
        serverActions: true
    },
    images: {
        domains:[
            'cdn.pixabay.com',
            'cafefcdn.com'
        ]
    },
    output: 'standalone'
};

export default nextConfig;

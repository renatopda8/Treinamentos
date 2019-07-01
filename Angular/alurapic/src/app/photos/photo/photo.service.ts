import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Photo } from './photo';
import { PhotoComment } from './photo-comment';

const API = 'http://localhost:3000';

@Injectable({ providedIn: 'root' })
export class PhotoService {

    constructor(private httpClient: HttpClient) { }

    listFromUser(userName: string) {
        return this.httpClient
            .get<Photo[]>(`${API}/${userName}/photos`);
    }

    listFromUserPaginated(userName: string, page: number) {
        const params = new HttpParams().append('page', page.toString());
        return this.httpClient
            .get<Photo[]>(`${API}/${userName}/photos`, { params });
    }

    upload(description: string, allowComments: boolean, file: File) {
        const formData = new FormData();
        formData.append('description', description);
        formData.append('allowComments', allowComments ? 'true' : 'false');
        formData.append('imageFile', file);

        return this.httpClient.post(`${API}/photos/upload`, formData);
    }

    findById(photoId: number) {
        return this.httpClient.get<Photo>(`${API}/photos/${photoId}`);
    }

    getComments(photoId: number) {
        return this.httpClient.get<PhotoComment[]>(`${API}/photos/${photoId}/comments`);
    }

    addComment(photoId: number, commentText: string) {
        return this.httpClient.post(`${API}/photos/${photoId}/comments`, { commentText });
    }
}
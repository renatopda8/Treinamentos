import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Photo } from './photo';
import { PhotoComment } from './photo-comment';
import { map, catchError } from 'rxjs/operators';
import { of, throwError } from 'rxjs';

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

    removePhoto(photoId: number) {
        return this.httpClient.delete(`${API}/photos/${photoId}/`);
    }

    like(photoId: number) {
        this.httpClient
            .post(`${API}/photos/${photoId}/like`, {}, { observe: 'response' })
            .pipe(map(res => true))
            .pipe(catchError(err => err.status == '304' ? of(false) : throwError(err)));
    }
}